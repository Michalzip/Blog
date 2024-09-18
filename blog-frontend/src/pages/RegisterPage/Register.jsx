import RegisterForm from "../../components/Auth/RegisterForm/RegisterForm";
import classess from "./Register.module.css";
export default function Register() {
  return (
    <div className={classess.registerPage}>
      <div className={classess.registerContainer}>
        <div className={classess.registerContent}>
          <h1>Register</h1>
          <RegisterForm />
          <div className={classess.loginHref}>
            <a className={classess.text} href="/auth/login">
              Have an Account? <a className={classess.logInText}>Log In</a>
            </a>
          </div>
        </div>
      </div>
    </div>
  );
}
