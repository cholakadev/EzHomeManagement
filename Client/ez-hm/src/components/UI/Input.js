import React from "react";
import classes from './Input.module.css';

const Input = props => {
 return (
    <div className={classes['input__control']}>
        <label>{props.label}</label>
        <input 
            type={props.type}
        />
    </div>
 );
}

export default Input;