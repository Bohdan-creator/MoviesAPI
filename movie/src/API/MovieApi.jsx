import axios from 'axios'
import Swal from "sweetalert2"
export default class MoviesAPI{
 
        async getFilmAndSave(title){
                try{       
                        console.log(title);               
                    const res = await axios.get(
                      'http://www.omdbapi.com/?i=tt3896198&apikey=96c36233&t='+title.MoviesName
                    )
                    console.log(res);
                    var moviesDetails = JSON.stringify(res.data);
                    var checkFilm = JSON.parse(moviesDetails);
                    if(checkFilm.Response==="False"){
                            throw Error
                    }
                    const saveFilm = await axios.post(
                        'https://localhost:44379/api/getSaveMovie',JSON.parse(moviesDetails)
                    )
                    Swal.fire("Saved", "Film finded", "success");
                    setTimeout(()=>window.location.assign("/AllMovie"),500);
                    return res;
                    
                  }catch(error){
                        Swal.fire("Oops...", "Film not found", "error");
                       console.log(error)
                  }
        }
        async getAllMovies(){
                try{
                        const res = await axios.get(
                                'https://localhost:44379/api/getSaveMovie'
                              )
                              console.log(res.data)
                              return res.data;
                }catch(error){
                        Swal.fire("Oops...", "You don't have movies", "error");
                }
        }

}