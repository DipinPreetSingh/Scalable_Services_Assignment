package com.ecommerce.shipping.entity;

public class ShippingOption {
    private String method;
    private double cost;
    private int estimatedDays;

    public ShippingOption(String method, double cost, int estimatedDays) {
        this.method = method;
        this.cost = cost;
        this.estimatedDays = estimatedDays;
    }

    public String getMethod() {
        return method;
    }

    public void setMethod(String method) {
        this.method = method;
    }

    public double getCost() {
        return cost;
    }

    public void setCost(double cost) {
        this.cost = cost;
    }

    public int getEstimatedDays() {
        return estimatedDays;
    }

    public void setEstimatedDays(int estimatedDays) {
        this.estimatedDays = estimatedDays;
    }
}

