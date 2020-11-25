import React from "react"
import * as Yup from 'yup';
import { Formik, Field, Form, ErrorMessage } from "formik";
import Api from '../API/CommentApi'
import css from '../Comments/Comment.css'
export default function AddComment(){


        let initialValues = {
                Comment: "",
                MovieId:parseInt(sessionStorage.getItem("MovieId")),
              };
              
              const validationSchema = Yup.object().shape({
                Comment: Yup.string()
                        .min(1, "Too short!")
                        .max(140, "Too long!")
                        .required("Required"),
                    });
                    function onSubmit(fields) {
                        console.log(fields);
                        PostComment(fields);  
                      }
                      async function PostComment(fields) {
                        try {
                         let api = new Api();
                          api.PostComment(fields);
                        } catch (error) {
                          console.log(error);
                         }
                      }
                      return (

                        <Formik
                        initialValues={initialValues}
                        validationSchema={validationSchema}
                        enableReinitialize
                        onSubmit={onSubmit}
                      >
                        {({ errors, touched }) => {
                          return (
                            <Form class="AddComment">
                              <h1>Add Comment</h1>
                              <br></br>
                              <Field
                                name="Comment"
                                className={
                                  "form" +
                                  (errors.Name && touched.Name ? " is-invalid" : "")
                                }
                              />
                              <ErrorMessage
                                name="Comment"
                                component="div"
                                className="invalid-feedback"
                              />
                              <div className="pt-3">
                                <button
                                  type="submit"
                                  className="btn btn-primary"
                                >
                                  Save
                                </button>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                 <a href="/AllMovie"
                                   type="submit"
                                   className="btn btn-danger"
                                   >     
                                Cancel
                                </a>
                              </div>
                            </Form>
                          );
                              }
                        }
                      </Formik>
                      );

}