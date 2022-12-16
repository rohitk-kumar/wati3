import logo from './logo.svg';
import './App.css';
import { useState } from 'react';

function App() {

const [num1,setNum1] = useState(0);
const [num2,setNum2] = useState(0);
const [sum,setSum] = useState(0);

function CallApi(){

  const data = {
    "Num1": num1,
    "Num2": num2
  }

  console.log(JSON.stringify(data));

  const headers = new Headers();
  headers.append("Content-Type","application/json");

  fetch("http://localhost:5000/add",{

  method : "Post",
  headers : headers,
  body : JSON.stringify(data) 
  }).then(response => response.json()      
  )
    .then(json => {
      console.log("The sum is: " + json["result"]);
      console.log(json);
      setSum(json["result"]);
    });



}
  return (
    <div className="App">
       <div>
        <label>
          Enter Number
          <input
          value = {num1}
          onChange = {e => setNum1( parseInt (e.target.value))}
          >
          </input>
        </label>
      </div>
      <div>
        <label>
          Enter Number
          <input
          value = {num2}
          onChange = {e => setNum2( parseInt (e.target.value))}
          >
          </input>
        </label>
      </div>
      <div>
        <button onClick={CallApi}>CallApi</button>
      </div>
      <div>
        <label>The sum is: {sum}</label>
      </div>
    </div>
    
  );
}

export default App;
