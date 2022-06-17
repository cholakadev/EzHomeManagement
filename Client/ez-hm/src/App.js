import React from 'react';
import './App.css';
import Header from './components/Layout/Header';
import Button from './components/UI/Button';

function App() {

  return (
    <React.Fragment>
      <Header />
      <div className='container'>
        <Button />
      </div>
    </React.Fragment>
  );
}

export default App;
