import PostDetail from "../../components/Posts/PostDetail/PostDetail";
import Comments from "../../components/Comments/Comments";
import classess from "./PostDetail.module.css";
export default function PostDetailPage() {
  return (
    //tutaj mozna uzyc contextu i postDetail bedzie ustawial kiedy offCanvas ma byc widoczne
    <div className={classess.PostDetailPage}>
      <PostDetail />
      {/* // dodac tutaj offCanvas */}
    </div>
  );
}
