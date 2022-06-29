import React from "react";
import classes from './Input.module.css';

const Input = props => {
    const onInputChangeHandler = event => {
        props.onChange(event.target.value);
    };
    
    return (
        <div className={classes['input__control']}>
            <label>{props.label}</label>
            <input 
                type={props.type}
                onChange={onInputChangeHandler}
            />
        </div>
    );
}

export default Input;