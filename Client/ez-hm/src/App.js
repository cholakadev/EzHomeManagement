import React from 'react';
import { Route, Switch } from 'react-router-dom';
import './App.css';
import Container from './components/Layout/Container';
import Header from './components/Layout/Header';
import Register from './pages/Register';

function App() {
  return (
    <React.Fragment>
        <Header />
        <Switch>
            <Container>
                <Route path='/register'>
                    <Register />
                </Route>
            </Container>
        </Switch>
    </React.Fragment>
  );
}

export default App;
