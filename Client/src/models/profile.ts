import { photo } from "./photo";

export interface Profile{
    username: string;
    displayName: string
    image?: string
    bio?: string
    photos?: photo[]
}

export interface ProfileEdit{
    username: string;
    displayName: string;
    bio: string;
}