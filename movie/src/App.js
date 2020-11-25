import logo from './logo.svg';
import 'bootstrap/dist/css/bootstrap.min.css';
import {
  BrowserRouter as Router,
  Route,
  Switch,
} from "react-router-dom";
import './App.css';
import Movie from './Movie/Movie'
import AllMovie from './Movie/AllMovies'
import AddComment from './Comments/AddComment'
import AllComments from './Comments/AllComments'

function App() {
  return (
    <Router>
      <Switch>
    <Route path="/findSaveMovie">
   <Movie></Movie>
   </Route>
   <Route path="/allMovie">
   <AllMovie></AllMovie>
   </Route>
   <Route path="/postComment">
   <AddComment></AddComment>
   </Route>
   <Route path="/allComments">
   <AllComments></AllComments>
   </Route>
   <Route path="/">
   <Movie></Movie>
   </Route>
   </Switch>
   </Router>

  );
}

export default App;
