import classess from "./Message.module.css";
import userIcon from "../../../assets/userIcon.png";
import heartIcon from "../../../assets/Post/heart.png";
function Message({ item }) {
  return (
    <li key={item.id} className={classess.messageList}>
      <div className={classess.message}>
        <div className={classess.userData}>
          <img className={classess.userImage} src={userIcon}></img>
          <div className={classess.userName}>{item.name}</div>
        </div>

        <div className={classess.userComment}>
          <h5>{item.comment}</h5>
        </div>

        <div className={classess.commentInfo}>
          <div className={classess.date}>{item.date}</div>
          <div className={classess.likeData}>
            <div className={classess.like}>
              <img
                src={heartIcon}
                alt="like Icon"
                width="15px"
                className={classess.postIcon}
              />
              like
            </div>
            <div className={classess.likes}>5 likes</div>
          </div>
        </div>
      </div>
    </li>
  );
}

export default Message;
