import React from "react";
import "./Card.css";

interface Props {
  companyName: string;
  ticker: string;
  price: number;
}

const Card = ({ companyName, ticker, price }: Props) => {
  return (
    <div className="card">
      <img
        src="https://w0.peakpx.com/wallpaper/596/400/HD-wallpaper-solo-leveling-jinwoo-with-weapons-solo-leveling-manga.jpg"
        alt="Image"
      />
      <div className="details">
        <h2>
          {companyName}({ticker})
        </h2>
        <p>{price}</p>
      </div>
      <p className="info">
        Lorem, ipsum dolor sit amet consectetur adipisicing elit. C umque ea hic
        culpa quaerat earum aut, sit vero facere illo unde? Commodi eaque
        numquam consequuntur sed soluta odio quod perferendis dolorem.
      </p>
    </div>
  );
};

export default Card;
