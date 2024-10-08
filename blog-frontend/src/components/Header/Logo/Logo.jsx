import { CodeIcon } from "./Icon";
import classes from "./Logo.module.css";
export default function Logo() {
  return (
    <div className={classes.logo}>
      <span>PotocznyBlog</span>
      <span className={classes.icon}>
        <CodeIcon />
      </span>
    </div>
  );
}
