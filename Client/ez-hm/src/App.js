import React, { useState } from 'react';
import './App.css';
import Container from './components/Layout/Container';
import Header from './components/Layout/Header';
import Input from './components/UI/Input';
import Modal from './components/UI/Modal';

function App() {
  return (
    <React.Fragment>
      <Header />
      <Container>
        <Input type='text' label='Apartment' />
      </Container>
    </React.Fragment>
  );
}

export default App;
