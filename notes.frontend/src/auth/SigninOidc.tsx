import { useEffect, FC } from "react";
import { useNavigate } from "react-router-dom";
import { signinRedirectCallback } from "./user-service";

const SigninOidc: FC<{}> = () => {
  const navigate = useNavigate();
  useEffect(() => {
    (async () => {
      await signinRedirectCallback();
      navigate("/");
    })();
  }, [navigate]);
  return <div>Redirecting...</div>;
};

export default SigninOidc;
