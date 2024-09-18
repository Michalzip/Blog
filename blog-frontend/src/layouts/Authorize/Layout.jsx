import { Outlet } from "react-router-dom";
export function Layout() {
  return (
    <html>
      <head>
        <meta charset="utf-8" />
        <meta http-equiv="X-UA-Compatible" content="IE=edge" />
        <title>Blog</title>
        <meta name="description" content="" />
        <meta name="viewport" content="width=device-width, initial-scale=1" />
        <link
          href="https://fonts.googleapis.com/css2?family=Playfair+Display:wght@400;700&display=swap"
          rel="stylesheet"
        ></link>
      </head>
      <body>
        <main>
          <Outlet />
        </main>
      </body>
    </html>
  );
}
