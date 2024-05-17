import { TextModule } from "@src/shared/scss"
import { LinkBrand } from "@src/shared/ui/link"
import Test_Img from "@src/shared/assets/Test/Samsung_logo.png"
import linkBrand from "@src/shared/ui/link/link-brand/linkBrand.module.scss"

export const Home = () => {
  return (
    <div>
        <h1 className={TextModule.p18}>Hello</h1>
        <LinkBrand to = "/"><img  className = {linkBrand.brand_img} src={Test_Img} alt="" /></LinkBrand>
    </div>
  )
}
