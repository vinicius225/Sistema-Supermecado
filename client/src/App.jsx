import { useState } from "react";
import { BrowserRouter, Routes, Route, Link } from "react-router-dom";
import "./App.css";
import { Home } from "./pages/Home";
import { Usuarios } from "./pages/Usuarios";
import '@fontsource/roboto/300.css';
import '@fontsource/roboto/400.css';
import '@fontsource/roboto/500.css';
import '@fontsource/roboto/700.css';

function App() {
  const [count, setCount] = useState(0);

  return (
    <>
      <h1>ola mundo</h1>

      <BrowserRouter>
        <ul>
          <li>
            <Link to="/Usuario">Usuarios</Link>
          </li>
          <li>
            <Link to="/Home">Home</Link>
          </li>
        </ul>
        <Routes>
          <Route path="/Usuario" element={<Usuarios />} />
          <Route path="/" element={<Home />} />
        </Routes>
      </BrowserRouter>
    </>
  );
}

export default App;
