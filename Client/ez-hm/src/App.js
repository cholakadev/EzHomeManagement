import React from 'react';
import './App.css';
import Container from './components/Layout/Container';
import Header from './components/Layout/Header';
import New from './components/News/New';
import Card from './components/UI/Card';

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
];

function App() {

  var lastestNews = DUMMY_DATA.map(lastestNew => 
    <li key={lastestNew.id}>
      <New
        title={lastestNew.title} 
        date={lastestNew.date} 
        content={lastestNew.content}
        author={lastestNew.author}
        apartment={lastestNew.apartment}
      />
    </li>);

  return (
    <React.Fragment>
      <Header />
      <Container>
        <div className='inner-container'>
          <div className='side-section'>
            <Card>
              <ul className='side-section-items'>
                {lastestNews}
              </ul>
            </Card>
          </div>
        </div>
      </Container>
    </React.Fragment>
  );
}

export default App;
