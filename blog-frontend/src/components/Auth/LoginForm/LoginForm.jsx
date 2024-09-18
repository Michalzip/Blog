import classess from "./LoginForm.module.css";
import { useAuthorizationForm } from "../../../hooks/useAuthorizeForm";
export default function LoginForm() {
  const {
    handleEmailChange,
    handlePasswordChange,
    handleSubmit,
    emailError,
    passwordError,
  } = useAuthorizationForm();

  return (
    <form onSubmit={handleSubmit}>
      <div className={classess.field}>
        <input
          required
          type="email"
          placeholder="Email"
          onChange={handleEmailChange}
        ></input>
        {emailError && <span className={classess.error}>Invalid Email</span>}
      </div>

      <div className={classess.field}>
        <input
          required
          type="password"
          placeholder="Password"
          onChange={handlePasswordChange}
        ></input>
        {passwordError && (
          <span className={classess.error}>Invalid Password</span>
        )}
      </div>

      <div className={classess.field}>
        <button type="submit">Submit</button>
      </div>
    </form>
  );
}
