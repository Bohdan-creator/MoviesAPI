import React,{Component} from 'react'
import Api from '../API/CommentApi'
export default class AllComments extends Component{
        constructor(){
                super();
                this.state={
                        comments:[]
                }
                this.AllComments();
        }
        AllComments = async () => {
                let api = new Api();
                let result =  await api.AllComments();
                console.log(result)
                this.setState({comments:result});
                }
                render(){
                        return(
                                <div>
                                        <h1 style={{textAlign:'center',textDecoration:'underline',}}
                                        >All Comments</h1>
                                        {this.state.comments.map(item=>(
                                                <li class="comment">{item.comment}</li>
                                        ))}
                                </div>
                        )
                }
}