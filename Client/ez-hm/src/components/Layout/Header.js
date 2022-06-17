import React from "react";
import classes from './Header.module.css'

const Header = () => {
    return (
        <React.Fragment>
            <header className={classes.header}>
                <h1 className={classes.title}>EzHM</h1>
                <div className={classes.actions}>
                    <ul>
                        <li>Dashboard</li>
                        {/* <li>News</li> */}
                        <li>Apartments</li>
                        <li>Residents</li>
                        {/* <li>Bills</li> */}
                    </ul>
                </div>
            </header>
        </React.Fragment>
    );
}

export default Header;