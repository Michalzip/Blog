import React from "react";
import classess from "./Posts.module.css";
import Post from "../Post/Post";
import data from "../../../mocks/postData.json";

function Posts() {
  return (
    <div className={classess.posts}>
      <div className={classess.postsContainer}>
        <div className={classess.RecentPostsText}>Recent Posts</div>
        <ul className={classess.listContainer}>
          {data.map((item) => (
            <Post key={item.id} item={item} />
          ))}
        </ul>
      </div>
    </div>
  );
}

export default Posts;
