import Logo from "../../../components/Header/Logo/Logo";
import SearchBar from "../../../components/Header/SearchBar/SearchBar";
import NavBar from "../../../components/Header/NavBar/NavBar";
import classes from "./Header.module.css";
export default function Header() {
  return (
    <header className={classes.header}>
      <nav className={classes.navContainer}>
        <Logo />
        <SearchBar />
        <NavBar />
      </nav>
    </header>
  );
}
