import { photo } from "./photo";

export interface Profile{
    username: string;
    displayName: string
    image?: string
    bio?: string
    photos?: photo[]
}