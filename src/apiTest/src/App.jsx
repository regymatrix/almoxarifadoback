import { useEffect, useState } from 'react'
import './App.css'

function App() {
  const [grupos, setGrupos] = useState([]);
  const [valorGrupos, setValorGrupos] = useState("");

 useEffect(() =>{
  buscarGrupos()
 },[]);

 function buscarGrupos(){
  fetch("https://localhost:7062/Grupo")
  .then(response => response.json())
  .then(data => setGrupos(data))
  .catch(error=>console.log(error))
 }

 const removerGrupo = (codigo) => {setGrupos(grupos.filter(grupos => grupos.iD_GRU!=codigo))};

 function addGrupo(){
  
 }

  return (
    <div className='App'>
      <div>
        <span>Nome do Grupo</span>
        <input type='text' value={valorGrupos} onChange={e=>setValorGrupos(e.target.value)}></input>
        <button onClick={()=>addGrupo()}>Adicionar</button>
      </div>
    <table>
      <thead>
        <tr>
          <th>Código</th>
          <th>Descricão</th>
          <th colSpan={2}>Opções</th>
        </tr>
      </thead>
      <tbody>

      {grupos.map((grupos)=>
        <tr key={grupos.iD_GRU}>
          <td>{grupos.iD_GRU}</td>
          <td>{grupos.nomE_GRU}</td>
          <td><button>Alterar</button></td>
          <td><button>Deletar</button></td>
        </tr>
      )}

      </tbody>
    </table>
    </div>
  )
}

export default App
