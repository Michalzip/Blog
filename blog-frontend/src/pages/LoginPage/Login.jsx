import LoginForm from "../../components/Auth/LoginForm/LoginForm";
import classess from "./Login.module.css";
export default function LoginPage() {
  return (
    <div className={classess.loginPage}>
      <div className={classess.loginContainer}>
        <div className={classess.loginContent}>
          <h1>Login</h1>
          <LoginForm />
          <div className={classess.registerHref}>
            <a className={classess.text} href="/auth/register">
              Not a member? <a className={classess.signUpText}>Sign up now</a>
            </a>
          </div>
        </div>
      </div>
    </div>
  );
}
