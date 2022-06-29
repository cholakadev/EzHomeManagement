import React from "react";
import Input from "../components/UI/Input";
import classes from './Register.module.css';

const Register = () => {
    return (
        <form className={classes['register-form']}>
            <Input type='text' label='Town' />
            <Input type='text' label='Country' />
            <Input type='text' label='Street' />
            <Input type='text' label='Street Number' />
            <Input type='text' label='Entrance Number' />
        </form>
    );
};

export default Register;