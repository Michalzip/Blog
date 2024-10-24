import React, { useContext } from "react";
import { useParams } from "react-router-dom";
import data from "../../../mocks/postData.json";
import classess from "./PostDetail.module.css";
import heartIcon from "../../../assets/Post/heart.png";
import viewIcon from "../../../assets/Post/view.png";
import shareIcon from "../../../assets/Post/send.png";
import addComentIcon from "../../../assets/Post/addcomment.png";
import { OffCanvasContext } from "../../../context/OffCanvasContext";
function PostDetail() {
  let { id } = useParams();
  //tutaj tak nie chlubnie bo i tak potem api bedize mi zwracac obiekt z bazy danych
  let findedPost = data.find((d) => d.id == id);
  const { toggleOffCanvas } = useContext(OffCanvasContext);

  return (
    <div className={classess.postDetailContainer}>
      <div className={classess.title}>{findedPost.title}</div>
      <div className={classess.postContent}>
        <div className={classess.subTitle}>{findedPost.subTitle}</div>
        <div className={classess.mainText}>{findedPost.mainText}</div>
      </div>
      <div className={classess.shareContent}>
        <div className={classess.leftContent}>
          <div className={classess.item}>
            <img
              src={viewIcon}
              alt="View Icon"
              width="25px"
              className={classess.icon}
            />
            {findedPost.views}
          </div>
          <div className={classess.item}>
            <img
              src={heartIcon}
              alt="like Icon"
              width="25px"
              className={classess.icon}
            />
            {findedPost.liked}
          </div>
        </div>
        <div className={classess.rightContent}>
          <div className={classess.item}>
            <button onClick={toggleOffCanvas}>
              <img
                src={addComentIcon}
                alt="add comment"
                width="25px"
                className={classess.icon}
              />
            </button>
          </div>
          <div className={classess.item}>
            <button>
              <img
                src={shareIcon}
                alt="share Icon"
                width="25px"
                className={classess.icon}
              />
            </button>
          </div>
        </div>
      </div>
    </div>
  );
}

export default PostDetail;
