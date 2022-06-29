import React, { useState } from "react";
import Input from "../components/UI/Input";
import Button from '../components/UI/Button';
import classes from './Register.module.css';

const Register = () => {
    const [enteredTown, setEnteredTown] = useState('');
    const [enteredCountry, setEnteredCountry] = useState('');
    const [enteredStreet, setEnteredStreet] = useState('');
    const [enteredStreetNumber, setEnteredStreetNumber] = useState('');
    const [enteredEntranceNumber, setEnteredEntranceNumber] = useState('');

    const onChangeTownHandler = value => setEnteredTown(value);
    const onChangeCountryHandler = value => setEnteredCountry(value);
    const onChangeStreetHandler = value => setEnteredStreet(value);
    const onChangeStreetNumberHandler = value => setEnteredStreetNumber(value);
    const onChangeEntranceNumberHandler = value => setEnteredEntranceNumber(value);

    const onSubmitRegisterFormHandler = event => {
        event.preventDefault();

        const entrance = {
            town: enteredTown,
            country: enteredCountry,
            street: enteredStreet,
            streetNumber: enteredStreetNumber,
            entranceNumber: enteredEntranceNumber
        };

        console.log(entrance);
    };

    return (
        <form className={classes['register-form']} onSubmit={onSubmitRegisterFormHandler}>
            <div>
                <Input type='text' label='Town' onChange={onChangeTownHandler} />
                <Input type='text' label='Country' onChange={onChangeCountryHandler} />
                <Input type='text' label='Street' onChange={onChangeStreetHandler} />
                <Input type='text' label='Street Number' onChange={onChangeStreetNumberHandler} />
                <Input type='text' label='Entrance Number' onChange={onChangeEntranceNumberHandler} />
            </div>
            <Button text='Register' />
        </form>
    );
};

export default Register;