import React, {Component, useEffect } from 'react';
import Api from '../API/MovieApi'
import {Input} from "reactstrap";
export default class AllMovies extends Component{

        constructor(){
        super();
                this.state={
                search:"",        
                movies:[]
                 };
        this.GetAllMovies();

         }
         GetAllMovies = async () => {
        let api = new Api();
        let result =  await api.getAllMovies();
        console.log(result)
        this.setState({movies:result});
        }
        redirectToAddComment(MovieId){
                sessionStorage.setItem("MovieId",MovieId);
                window.location.assign("/postComment");
        }
        redirectToAllComments(MovieId){
                sessionStorage.setItem("MovieId",MovieId);
                window.location.assign("/allComments");
        }
        onChange=e=>{
                this.setState({search:e.target.value})
        }
        render(){
         return(

            <div>
                                    <Input icon="search"
                                   class="search"
                      placeholder='Search item'
                      onChange={this.onChange}
                      /> 
            {this.state.movies.map(item=>{
                    if(item===null){
                            return(
                                    <h1>You don't have movies</h1>
                            )
                    }
                    
                    if(item.title!==""&&item.title.indexOf(this.state.search)===-1){
                            return null;
                    }
                return(
                    <div class="grid-container">
                            <div class="item">
                    <img class="poster"src={item.poster}></img>
                    <div class="details">
                    <h2>Actors</h2>
                    <p class="info">{item.actors}</p>
                    <h2>Released</h2>
                     <p class="info">{item.released}</p>
                     <h2>Writer</h2>
                     <p class="info">{item.writer}</p>
                     <h2>Genre</h2>
                     <p class="info">{item.genre}</p>
                     <h2>Released</h2>
                     <p class="info">{item.released}</p>
                     <h2>Runtime</h2>
                     <p class="info">{item.runtime}</p>
                     <h2>Describe</h2>
            <p class="info">{item.plot}</p>
                    </div>
                    <div>
                            <button class="btn btn-info" style={{marginLeft:430+'px'}} onClick={()=>this.redirectToAddComment(item.id)}>Add Comment</button>
                                    <h2 style={{textAlign:'center',textDecoration:'underline',color:"#007bff"}}>
                                            Comments</h2>
                                    <div class="comments">
                            {item.comments.map((comment,index)=>{
                            if(index>2&&index<=3){
                                    return(
                                            <a type="button" class="comment" onClick={()=>this.redirectToAllComments(item.id)}>
                                                    View All Comentaries({item.comments.length})
                                                    </a>
                                          )
                            }
                            if(comment!==null&&index<=2){
                                    return(
                            <li class="comment" style={{marginLeft:250+'px'}}>{comment.comment}</li>
                                    )
                            }
                            if(comment===null){
                                    return(
                                            <h4 style={{textAlign:"center"}}>0 comments</h4>
                                    )
                            }
            })}
            </div>
            </div>
                    </div>
                    </div>
            
             ) })}
            </div>  
        );
            }
}