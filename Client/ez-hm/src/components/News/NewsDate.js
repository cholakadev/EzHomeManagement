import React from "react";
import classes from './NewsDate.module.css';

const NewsDate = props => {
    const month = props.date.toLocaleString('en-US', {month: 'long'});
    const day = props.date.toLocaleString('en-US', {day: '2-digit'});
    const year = props.date.getFullYear();

    return (
        <div className={classes['news-date__container']}>
            <div className={classes['news-date']}>{day} {month}, {year}</div>
        </div>
    );  
}

export default NewsDate;