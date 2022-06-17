import React from "react";
import classes from './Button.module.css';

const Button = props => {
    return (
        <button onClick={props.onClick} className={classes.button}>Click me!</button>
    );
}

export default Button;