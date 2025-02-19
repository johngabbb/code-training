import React from "react";
import Card from "../Card/Card";

interface Props {}

const CardList = (props: Props) => {
  return (
    <div>
      <Card companyName="Max" ticker="Beagle" price={99} />
      <Card companyName="Hunter" ticker="Husky" price={99} />
    </div>
  );
};

export default CardList;
