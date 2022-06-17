import React from "react";
import Card from "../UI/Card";
import classes from './New.module.css';
import NewsDate from "./NewsDate";

const New = props => {
    return (
        <Card>
            <div className={classes.new}>
                <div className={classes.header}>
                    <div className={classes.title}>{props.title}</div>
                    <div className={classes.date}>
                        <NewsDate date={props.date} />
                    </div>
                </div>
                <div className={classes.content}>
                    {props.content}
                </div>
                <div className={classes.footer}>
                    <span className={classes.author}>Author: {props.author}, Ap. {props.apartment}</span>
                </div>
            </div>
        </Card>
    );
}

export default New;