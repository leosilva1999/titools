import { useState } from 'react'
import './App.css'

function App() {
  const api = "https://localhost:7084/api";
  const testFindUsers = async() => {

    try{
      const res = await fetch(api +"/Callers", {
        mode: 'cors',
    })
      .then((res) => res.json())
      .catch((err) => err);
      
      return res;
    }catch(error){
      console.log(error)
    }
  }

  console.log(testFindUsers())

  return (   
      <div>
          <h1>teste</h1>
      </div>
  )
}

export default App
