import React from 'react';
import './App.css';
import Container from './components/Layout/Container';
import Header from './components/Layout/Header';
import Input from './components/UI/Input';

const DUMMY_DATA = [
  {
    id: 1,
    title: 'Vacation',
    content: 'Whole family is on vacation, please watch for robbers.',
    author: 'Georgi Cholakov',
    apartment: '10A',
    date: new Date(2022, 7, 18)
  },
  {
    id: 2,
    title: 'Free parkspace',
    content: 'Since we will be out of the town for 20 days, our parking space is free and can be used until 21/09/2022 22:00 PM.',
    author: 'Georgi Cholakov',
    apartment: '10A',
    date: new Date(2022, 7, 20)
  },  
  {
    id: 3,
    title: 'Free parkspace',
    content: 'Since we will be out of the town for 20 days, our parking space is free and can be used until 21/09/2022 22:00 PM.',
    author: 'Georgi Cholakov',
    apartment: '10A',
    date: new Date(2022, 7, 20)
  },
  {
    id: 4,
    title: 'Free parkspace',
    content: 'Since we will be out of the town for 20 days, our parking space is free and can be used until 21/09/2022 22:00 PM.',
    author: 'Georgi Cholakov',
    apartment: '10A',
    date: new Date(2022, 7, 20)
  },
];

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
