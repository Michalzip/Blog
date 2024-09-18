import classess from "./SearchPosts.module.css";
import { Link } from "react-router-dom";
export default function SearchPost({ item }) {
  return (
    <ul>
      <li className={classess.searchPost} key={item.id}>
        <a className={classess.title} href="/auth/login">
          {item.title}
        </a>
      </li>
    </ul>
  );
}
