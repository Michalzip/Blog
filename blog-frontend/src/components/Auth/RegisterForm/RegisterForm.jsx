import classess from "./RegisterForm.module.css";
import { useAuthorizationForm } from "../../../hooks/useAuthorizeForm";
export default function RegisterForm() {
  const {
    handleEmailChange,
    handlePasswordChange,
    handleRepatPasswordChange,
    handleSubmit,
    emailError,
    passwordError,
    passwordRepeatError,
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
        <input
          required
          type="password"
          placeholder="Repeat Password"
          onChange={handleRepatPasswordChange}
        ></input>
        {passwordRepeatError && (
          <span className={classess.error}>Password Not Match</span>
        )}
      </div>

      <div className={classess.field}>
        <button type="submit">Submit</button>
      </div>
    </form>
  );
}
