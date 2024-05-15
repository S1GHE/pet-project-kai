import { Layout } from "@src/features/Layout"
import { Route, Routes } from "react-router-dom"
import { PublicLayoutRoutes } from "./paths"

export const RouterApp = () => {
  return (
    <Routes>
        <Route path="/" element={<Layout/>}>
            {PublicLayoutRoutes.map(el => <Route path={el.path} element={el.element} key={el.path}/>)}
        </Route>
    </Routes>
  )
}
