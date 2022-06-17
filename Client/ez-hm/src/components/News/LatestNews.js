import React from "react";
import classes from './LatestNews.module.css';
import New from './New';

const LastestNews = props => {
    var lastestNews = props.latestNews.map(lastestNew => 
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
        <ul className={classes['latest-news']}>
            {lastestNews}
        </ul>
    );
}

export default LastestNews;