import { lazy } from "react";

export const HomeChunk = lazy(() => import("@src/pages/home/Home").
    then(module => ({default: module.Home})))
