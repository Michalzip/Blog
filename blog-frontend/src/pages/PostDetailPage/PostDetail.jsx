import PostDetail from "../../components/Posts/PostDetail/PostDetail";
import classess from "./PostDetail.module.css";
import OffCanvasMenu from "../../components/OffCanvasMenu/OffCanvasMenu";
import { OffCanvasProvider } from "../../context/OffCanvasContext";
export default function PostDetailPage() {
  return (
    //tutaj mozna uzyc contextu i postDetail bedzie ustawial kiedy offCanvas ma byc widoczne
    <OffCanvasProvider>
      <div className={classess.PostDetailPage}>
        <OffCanvasMenu />
        <PostDetail />
      </div>
    </OffCanvasProvider>
  );
}
