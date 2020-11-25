import React from 'react'
import Api from '../API/MovieApi'
import { Form, Formik,Field,ErrorMessage } from 'formik';
import css from '../Movie/Movie.css'
import Button from 'react-bootstrap/Button'; 
export default function Movie(){

        let initialValues = {
                MoviesName:""
              }
              function onSubmit(fields){
                try{
                        console.log(fields);
                        GetAndSaveFilm(fields);
                }
                catch(error){
                        console.log("error");
                }  
        }
        async function GetAndSaveFilm(fields){
            let api = new Api();
            api.getFilmAndSave(fields);
        }
        return(
                <div>
                <h1 class="header">Find film</h1>
                <Formik
                initialValues={initialValues}
                onSubmit={onSubmit}
                >
                        <Form>
                        <Field
                        name="MoviesName"
                        className="form-control"
                          />
                           <ErrorMessage
                          name="MoviesName"
                          component="div"
                       className="invalid-feedback"
                          />
                          <button class=" confirm btn btn-info">Search</button>
                        </Form>
                        
                </Formik>
                </div>
        )
}