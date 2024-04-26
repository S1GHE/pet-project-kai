import { ContainerModule } from "@src/shared/scss"
import { Outlet } from "react-router-dom"
import classes from "@src/features/Layout/layout.module.scss";

export const Layout = () => {
  return (
    <main className={classes.flex_wrapper}>
        <header>
            <div className={ContainerModule.container}>
                Подвал
            </div>
        </header>

        <section className={ContainerModule.container}>
            <Outlet/>
        </section>

        <footer>
            <div className={ContainerModule.container}>
                Подвал
            </div>
        </footer>
    </main>
  )
}
