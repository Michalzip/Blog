import classess from "./SearchPosts.module.css";
import SearchPost from "./SearchPost";
import data from "../../mocks/postData.json";
import { useSearchState } from "../../hooks/useSearchState";

export default function SearchPosts() {
  const { filteredData } = useSearchState();
  const filteredPosts = filteredData(data);
  return (
    <div className={classess.searchPosts}>
      <ul className={classess.seachPostsList}>
        {filteredPosts.map((item) => (
          <SearchPost key={item.id} item={item} />
        ))}
      </ul>
    </div>
  );
}
