import data from "../../../mocks/userData.json";
import Message from "../Message/Message";
import classess from "./Messages.module.css";
function Messages() {
  return (
    <div className={classess.messageContainer}>
      <ul>
        {data.map((item) => (
          <Message key={item.id} item={item} />
        ))}
      </ul>
    </div>
  );
}

export default Messages;
