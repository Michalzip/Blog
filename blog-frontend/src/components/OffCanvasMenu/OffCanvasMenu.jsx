import classess from "./OffCanvasMenu.module.css";
import React, { useContext } from "react";
import { OffCanvasContext } from "../../context/OffCanvasContext";
import Messages from "../Messages/Messages/Messages";

function OffCanvasMenu() {
  const { isOffCanvasOpen } = useContext(OffCanvasContext);
  return (
    <div
      className={`${classess.sidenav} ${isOffCanvasOpen ? classess.open : ""}`}
    >
      <div className={classess.title}>Comments Section</div>
      <form>
        <div className={classess.MessageInputContainer}>
          <div className={classess.MessageInput}>
            <input required type="text" placeholder="Message"></input>
          </div>
          <button className={classess.CommentButton}>Add</button>
        </div>
      </form>
      <Messages />
    </div>
  );
}

export default OffCanvasMenu;
