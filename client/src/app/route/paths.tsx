import { HomeChunk } from "@src/pages/home";
import { IRoute } from "../types/routeType";

export const PublicLayoutRoutes: Array<IRoute> = [
    {path: "/", element: <HomeChunk/>}
]