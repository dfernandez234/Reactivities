import { photo } from "./photo";

export interface Profile{
    username: string;
    displayName: string
    image?: string
    bio?: string
    followersCount: number;
    followingCount: number;
    following: boolean;
    photos?: photo[]
}

export interface ProfileEdit{
    username: string;
    displayName: string;
    bio: string;
}