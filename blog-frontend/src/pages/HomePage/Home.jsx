import Posts from "../../components/Posts/Posts/Posts";

import classes from "./Home.module.css";
export default function HomePage() {
  return (
    <div className={classes.HomePage}>
      <div className={classes.ImageBackground}></div>
      <Posts />
    </div>
  );
}
