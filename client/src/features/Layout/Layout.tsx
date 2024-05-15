import { ContainerModule } from "@src/shared/scss"
import { Outlet } from "react-router-dom"
import classes from "@src/features/Layout/layout.module.scss";
import {Header, Footer} from "@src/features/Layout/section";
import { LinkBrand } from "@src/shared/ui/link";

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
        </section>
        <footer>
            <div className={ContainerModule.container}>
                <Footer/>
            </div>
        </footer>
    </main>
  )
}
