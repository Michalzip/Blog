import {
  createBrowserRouter,
  RouterProvider,
  Navigate,
} from "react-router-dom";
import { Layout as LayoutUser } from "./layouts/User/Layout";
import { Layout as LayoutAuthorize } from "./layouts/Authorize/Layout";
import ErrorPage from "./pages/ErrorPage/Error";
import pages from "./pages/pages";

export default function App() {
  return <RouterProvider router={router} />;
}

const router = createBrowserRouter([
  {
    path: "/",
    element: <LayoutUser />,
    errorElement: <ErrorPage />,
    children: [
      { path: "home", element: <pages.HomePage /> },
      { path: "posts/:id", element: <pages.PostDetailPage /> },
      { path: "about", element: <pages.AboutMe /> },
      { path: "", element: <Navigate to="home" /> },
    ],
  },

  {
    path: "/auth",
    element: <LayoutAuthorize />,
    children: [
      { path: "login", element: <pages.LoginPage /> },
      { path: "register", element: <pages.RegisterPage /> },
    ],
  },
]);
