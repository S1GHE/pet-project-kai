import { ContainerModule } from "@src/shared/scss"
import { Outlet } from "react-router-dom"
import classes from "@src/features/layout/layout.module.scss";
import {Header, Footer} from "@src/features/layout/section";

export const Layout = () => {
  return (
    <main className={classes.flex_wrapper}>
        <header>
            <div className={ContainerModule.container}>
                <Header/>
            </div>
        </header>

        <section className={ContainerModule.container}>
            <Outlet/>
            <br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/>
        </section>

        <footer>
            <div className={ContainerModule.container}>
                <Footer/>
            </div>
        </footer>
    </main>
  )
}
