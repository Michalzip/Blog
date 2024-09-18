import { useState } from "react";
export const useAuthorizationForm = () => {
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const [repeatPassword, setRepeatPassword] = useState("");

  const [emailError, setEmailError] = useState(false);
  const [passwordError, setPasswordError] = useState(false);
  const [passwordRepeatError, setPasswordRepeatError] = useState(false);

  const handleEmailChange = (e) => {
    setEmail(e.target.value);
    console.log(email);
  };

  const handlePasswordChange = (e) => {
    setPassword(e.target.value);
  };

  const handleRepatPasswordChange = (e) => {
    setRepeatPassword(e.target.value);
  };

  const validateForm = () => {
    const emailPattern = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$/;
    const passwordPattern =
      /^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*])(?=.{8,})/;

    if (!emailPattern.test(email)) {
      setEmailError(true);
    } else {
      setEmailError(false);
    }

    if (!passwordPattern.test(password)) {
      setPasswordError(true);
    } else {
      setPasswordError(false);
    }

    if (!passwordPattern.test(repeatPassword)) {
      setPasswordRepeatError(true);
    } else {
      setPasswordRepeatError(false);
    }
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    validateForm();
  };

  return {
    handleEmailChange,
    handlePasswordChange,
    handleRepatPasswordChange,
    emailError,
    passwordError,
    passwordRepeatError,
    handleSubmit,
  };
};
