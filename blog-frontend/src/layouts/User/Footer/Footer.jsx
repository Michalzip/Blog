import classes from "./Footer.module.css";
import { Link } from "react-router-dom";
export default function Footer() {
  return (
    <div className={classes.footer}>
      <div className={classes.footerContent}>
        <ul className={classes.menu}>
          <li className={classes.item}>
            <Link to="/Home">Blog</Link>
          </li>
          <li className={classes.item}>
            <Link to="/about">About Me</Link>
          </li>
          <li className={classes.item}>
            <Link to="/">Contact</Link>
          </li>
          <li className={classes.item}>
            <Link to="/">Log In</Link>
          </li>
        </ul>

        <div className={classes.subscribeContainer}>
          <div className={classes.subscribeText}>
            <p>
              Subscribe here and get the latest travel tips and my insider
              secrets!
            </p>
          </div>

          <div className={classes.subcribeInputContainer}>
            <label for="email">Email *</label>
            <br />

            <input
              required
              type="email"
              id="email"
              className={classes.subcribeInput}
              autocomplete="off"
            ></input>
          </div>
          <button className={classes.subscribeButton}>Subscribe</button>
        </div>
      </div>
      <div className={classes.copyRightSection}>
        <p>© 2035 by On the Michał. Powered and secured by Me</p>
      </div>
    </div>
  );
}
