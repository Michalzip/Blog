import { Link } from "react-router-dom";
import classes from "./NavBar.module.css";

export default function NavBar() {
  return (
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
    </ul>
  );
}
