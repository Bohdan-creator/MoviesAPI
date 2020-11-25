import Swal from 'sweetalert2'
import axios from 'axios'


export default class CommentsAPI{
   
        async PostComment(fields){
                try {
                        console.log(fields);
                        const res = await axios.post
                        ('https://localhost:44379/api/comment',fields); 
                        Swal.fire("Success", "Your post added", "success");
                        setTimeout(()=>window.location.assign("/AllMovie"),1000);

                        return res;
                     } catch (error) {
                       Swal.fire("Oops...", "Your post doesn't comment", "error");
                     }
        }
        async AllComments(){
                try {
                        const res = await axios.get
                        ('https://localhost:44379/api/comment/'+sessionStorage.getItem("MovieId")); 
                        console.log(res);
                        return res.data;
                     } catch (error) {
                       Swal.fire("Oops...", "Your post doesn't comment", "error");
                     }
        }
}