import React from "react";
import classess from "./Post.module.css";
import userIcon from "../../../assets/userIcon.webp";
import heartIcon from "../../../assets/Post/heart.png";
import viewIcon from "../../../assets/Post/view.png";
import commentIcon from "../../../assets/Post/comment.png";

function Post({ item }) {
  return (
    <li key={item.id} className={classess.listItem}>
      <div className={classess.itemDetails}>
        <img
          src={userIcon}
          alt="User Icon"
          className={classess.userIcon}
          width="35px"
        />
        <div className={classess.information}>
          <div className={classess.informationAuthor}>
            <span className={classess.itemAuthor}>{item.author}</span>
          </div>
          <div className={classess.informationTime}>
            <span className={classess.date}> {item.date}</span>
            <span className="item-readTime">{item.readTime} min</span>
          </div>
        </div>
      </div>
      <a className={classess.item} href={item.link}>
        <div className={classess.listContent}>
          <h2 className={classess.itemTitle}>{item.title}</h2>
          <p className={classess.itemText}>{item.text}</p>
        </div>
      </a>
      <div className={classess.itemStats}>
        <div className={classess.itemViews}>
          <img
            src={viewIcon}
            alt="View Icon"
            width="15px"
            className={classess.postIcon}
          />
          {item.views}
        </div>
        <div className={classess.itemLike}>
          <img
            src={heartIcon}
            alt="like Icon"
            width="15px"
            className={classess.postIcon}
          />
          {item.liked}
        </div>

        <div className={classess.itemComment}>
          <img
            src={commentIcon}
            alt="comment Icon"
            width="15px"
            className={classess.postIcon}
          />
          {item.liked}
        </div>
      </div>
    </li>
  );
}

export default Post;
