import classess from "./Comments.module.css";
function Comments() {
  return (
    <div className={classess.CommentsContainer}>
      <div className={classess.CommentsContent}>
        <div className={classess.CommentsTitle}>Comments</div>
        <div className={classess.CommentsInputContainer}>
          <div className={classess.a}>
            <input placeholder="Write a comment..." type="text"></input>
            <div className={classess.buttonContainer}>
              <button>Publish</button>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
}

export default Comments;
