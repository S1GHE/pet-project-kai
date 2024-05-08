import { Suspense } from "react";
import { BrowserRouter } from "react-router-dom";
import "./index.scss";
import { RouterApp } from "./route/RouterApp";

export const App = () => {
  return (
    <Suspense fallback={<div>Загрузка...</div>}>
      <BrowserRouter>
        <RouterApp/>
      </BrowserRouter>
    </Suspense>
  )
}
